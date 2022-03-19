<template>
  <div class="tag">
    {{ props.tag }}
    <button @click="emitRemove" class="tag__btn" v-if="props.allowRemove">
      <plus class="tag__icon" />
    </button>
  </div>
</template>

<script>
import Plus from "@/assets/plus";
export default {
  name: "Tag",
  components: {
    Plus,
  },
};
</script>

<script setup>
import { defineProps, defineEmits } from "vue";
const props = defineProps(["tag", "allowRemove"]);
const emits = defineEmits(["remove"]);
const emitRemove = () => {
  emits("remove", props.tag);
};
</script>

<style scoped lang="scss">
.tag {
  color: var(--powder700);
  border: 1px solid var(--powder500);
  background-color: var(--powder100);
  padding: 2px 5px;
  display: block;
  width: fit-content;
  border-radius: 3px;
  font-size: 13px;
  white-space: nowrap;
  display: flex;
  align-items: center;
  cursor: pointer;
  &:hover {
    background-color: var(--powder600);
  }
  &__btn {
    border: none;
    padding: 0;
    border-radius: 50%;
    background-color: #fff;
    width: 14px;
    height: 14px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-left: 4px;
    cursor: pointer;
    &:hover {
      background-color: #c03433;
      svg {
        fill: var(--black900);
      }
    }
  }
  &__icon {
    width: 10px;
    fill: var(--black400);
    height: 10px;
    transform: rotate(45deg);
  }
}
</style>
