<template>
  <div class="expander">
    <div @click="toggle" class="expander__head">
      <slot name="head"></slot>
    </div>
    <transition name="slide-fade">
      <div v-if="isOpened">
        <slot name="body"></slot>
      </div>
    </transition>
  </div>
</template>

<script>
export default {
  name: "Expander",
};
</script>

<script setup>
import { ref } from "vue";
const isOpened = ref(false);
const toggle = () => (isOpened.value = !isOpened.value);
</script>

<style scoped lang="scss">
.expander {
  &__head {
    cursor: pointer;
    user-select: none;
  }
}
.slide-fade-enter-active {
  transition: all 0.2s ease-out;
}

.slide-fade-leave-active {
  transition: all 0.2s cubic-bezier(1, 0.5, 0.8, 1);
}

.slide-fade-enter-from,
.slide-fade-leave-to {
  transform: translateX(20px);
  opacity: 0;
}
</style>
