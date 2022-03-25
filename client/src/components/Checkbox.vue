<template>
  <label class="checkbox" @click.prevent="handleClick">
    <input :disabled="props.disabled" class="visually-hidden" type="checkbox" />
    <span
      @keydown.enter.prevent="handleClick"
      tabindex="1"
      class="checkbox__icon-wrp"
      :class="{
        'checkbox__icon-wrp--active': props.checked || isChecked,
        'checkbox__icon-wrp--disabled': props.disabled,
      }"
    >
      <checkbox-icon
        v-show="props.checked === true || isChecked === true"
        class="checkbox__icon"
      />
    </span>
    <span>
      <slot name="label"></slot>
    </span>
  </label>
</template>

<script>
export default {
  name: "Checkbox",
};
</script>

<script setup>
import CheckboxIcon from "@/assets/checkbox.vue";
import { defineProps, defineEmits, ref, onMounted, watch } from "vue";

const props = defineProps({
  checked: {
    default: false,
    required: false,
    type: Boolean,
  },
  disabled: {
    default: false,
    required: false,
    type: Boolean,
  },
  arrayValue: {
    required: false,
  },
  modelValue: {
    type: Array,
  },
});
const isChecked = ref(false);
onMounted(() => {
  if (props.modelValue?.includes(props.arrayValue)) {
    isChecked.value = true;
  }
});

watch(
  () => props.modelValue,
  () => {
    if (
      props.modelValue.find((el) => {
        return el === props.arrayValue;
      })
    ) {
      isChecked.value = true;
    } else {
      isChecked.value = false;
    }
  }
);
const emits = defineEmits(["change", "update:modelValue"]);
const handleClick = () => {
  if (props.disabled) {
    return;
  } else if (props.arrayValue && props.modelValue) {
    let arr = props.modelValue;
    if (arr?.includes(props.arrayValue)) {
      arr = arr.filter((el) => el !== props.arrayValue);
      isChecked.value = false;
    } else {
      arr.push(props.arrayValue);
      isChecked.value = true;
    }
    emits("update:modelValue", arr);
    return;
  } else {
    emits("change", !props.checked);
  }
};
</script>

<style lang="scss" scoped>
.checkbox {
  display: flex;
  align-items: center;
  cursor: pointer;
  width: fit-content;

  &__icon-wrp {
    width: 17px;
    height: 17px;
    border: 1.5px solid var(--black200);
    display: flex;
    align-items: center;
    justify-content: center;
    margin-right: 5px;
    position: relative;
    border-radius: 3px;
    padding: 2px;

    &:active,
    &:focus {
      outline: 1px solid var(--powder700);
    }

    &--disabled {
      opacity: 0.6;
    }

    &--active {
      background-color: var(--blue500);
    }

    &:hover {
      opacity: 0.6;
    }
  }

  &__icon {
    fill: white;
    width: 15px;
  }
}
</style>