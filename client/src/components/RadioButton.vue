<template>
  <label
    @click="emitUpdate"
    class="radiobutton"
    :class="{ 'radiobutton--disabled': props.disabled }"
  >
    <input
      :disabled="props.disabled"
      :checked="isChecked"
      class="visually-hidden radiobutton__input"
      type="radio"
    />
    <span
      @keydown.space.enter="emitUpdate"
      tabindex="1"
      class="radiobutton__round"
    >
    <span></span></span>
    <slot name="label"></slot>
  </label>
</template>

<script>
export default {
  name: "RadioButton",
};
</script>

<script setup>
import { computed, defineEmits, defineProps } from "vue";
const emits = defineEmits(["update:modelValue"]);
const props = defineProps({
  modelValue: {
    required: true,
  },
  arrayValue: {
    required: true,
  },
  disabled: {
    required: false,
    type: Boolean,
    default: false,
  },
});
const emitUpdate = () => {
  if (props.disabled) return;
  emits("update:modelValue", props.arrayValue);
};
const isChecked = computed(() => {
  return props.modelValue === props.arrayValue;
});
</script>

<style lang="scss" scoped>
.radiobutton {
  display: flex;
  cursor: pointer;
  align-items: center;
  &--disabled {
    opacity: 0.4;
  }
  &__input:checked ~ &__round {
    background-color: var(--blue500);
    span { 
      width: 5px;
      height: 5px;
      background-color: var(--black900);
      border-radius:50%;
    }
  }
  &__round {
    height: 15px;
    width: 15px;
    border: 1px solid var(--black200);
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 50%;
    margin-right: 5px;
    &:hover {
      opacity: 0.8;
    }
    &:focus,
    &:active {
      outline: 1.5px solid var(--powder700);
    }
  }
}
</style>